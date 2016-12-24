using SocialFashion.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
namespace SocialFashion.Web.Controllers
{
    public class UserController : Controller
    {


        // GET: User
        public ActionResult Profile(string id)
        {
            using (SocialFashionDbContext db = new SocialFashionDbContext())
            {
                var currentUserId = User.Identity.GetUserId();
                if (Object.Equals(currentUserId, id))
                {
                    ViewBag.IsFanOrOwn = 0;
                }
                else
                {
                    var userFan = db.Fans_GetFanByUser(currentUserId, id).FirstOrDefault();

                    if (userFan != null)
                    {
                        if(userFan.SenderId == currentUserId)
                        {
                            ViewBag.FriendStatus = userFan.Status;
                            ViewBag.checkHaveAddFriend = 0;
                        }
                        if (userFan.RequestId == currentUserId)
                        {
                            ViewBag.FriendStatus = userFan.Status;
                            AspNetUsers_CheckAddFriend_Result checkHaveAddFriend = db.AspNetUsers_CheckAddFriend(id).FirstOrDefault();
                            if (checkHaveAddFriend != null)
                            {
                                ViewBag.checkHaveAddFriend = 1;
                            }
                            else
                            {
                                ViewBag.checkHaveAddFriend = 0;
                            }
                        }
                        
                    }
                    else
                    {
                        ViewBag.checkHaveAddFriend = 0;
                        ViewBag.IsAddFan = 1;
                        ViewBag.FriendStatus = -1;
                    }

                    
                     ViewBag.IsFanOrOwn = 1;
                }

                Users_GetById_Result userProfile = db.Users_GetById(id).FirstOrDefault();
                return View(userProfile);
            }

        }

        public ActionResult AllMember()
        {
            using (SocialFashionDbContext db = new SocialFashionDbContext())
            {
                List<Users_List_Result> listMember = db.Users_List().ToList();
                return View(listMember);
            }

        }

        [HttpPost]
        public JsonResult AddFriend(string id, string msg)
        {
            using (SocialFashionDbContext db = new SocialFashionDbContext())
            {
                var currentUserId = User.Identity.GetUserId();
                var result = db.Fans_Insert(currentUserId, id, 0, msg).FirstOrDefault();
                if (result > 0)
                {
                    return new JsonResult { Data = true, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }
                else
                {
                    return new JsonResult { Data = false, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }


            }

        }

        [HttpPost]
        public JsonResult ReplyFriend(string RequestId, string StatusReply)
        {
            using (SocialFashionDbContext db = new SocialFashionDbContext())
            {
                var currentUserId = User.Identity.GetUserId();
                int? result = db.Fans_Update(RequestId,currentUserId,StatusReply).FirstOrDefault();
                if (result > 0)
                {
                    return new JsonResult { Data = true, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }
                else
                {
                    return new JsonResult { Data = false, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }

            }

        }
    }
}