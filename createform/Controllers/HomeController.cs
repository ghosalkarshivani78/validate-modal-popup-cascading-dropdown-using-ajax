using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using createform.Models;

namespace createform.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        usercascadEntities ts = new usercascadEntities();

        public ActionResult Index()
        {
            var db = ts.empstates.ToList();
            List<userform> li = new List<userform>();
            foreach(var i in db)
            {
                userform u = new userform();
                u.id = i.id;
                u.firstname = i.firstname;
                u.lastname = i.lastname;
                u.email = i.email;
                u.address = i.address;
                u.countryid = ts.countries.Where(x => x.countryid == i.countryid).SingleOrDefault().countryname;
                u.stateid = ts.states1.Where(x => x.stateid == i.stateid).SingleOrDefault().statename;
                u.cityid = ts.city2.Where(x => x.cityid == i.cityid).SingleOrDefault().cityname;
                u.number =i.number.ToString();
                li.Add(u);
            }
            return View(li);
        }

        
        // GET: /Home/Create

        public ActionResult Create()
        {
            List<dll> dll = new List<Models.dll>(){
            new dll{
            id=0,
            name="Please Select"
          
                }
            };
            userform u = new userform();
            var countrylist=ts.countries.ToList();
            u.countries = new SelectList(countrylist, "countryid", "countryname");

            var statelist = ts.states1.ToList();
            u.states = new SelectList(dll, "id", "name");

            var citylist = ts.city2.ToList();
            u.cities = new SelectList(dll, "id", "name");
            return View(u);
        } 

        //
        // POST: /Home/Create

        [HttpPost]
        public ActionResult Create(userform uf)
        {
            userform u = new userform();
            var countrylist = ts.countries.ToList();
            u.countries = new SelectList(countrylist, "countryid", "countryname");

            var statelist = ts.states1.ToList();
            u.states = new SelectList(statelist, "id", "name");

            var citylist = ts.countries.ToList();
            u.cities = new SelectList(citylist, "id", "name");
            try
            {
                var t = ts.empstates.Where(x => x.email == uf.email).SingleOrDefault();
                if (t == null)
                {
                    empstate s = new empstate();
                    s.id = uf.id;
                    s.firstname = uf.firstname;
                    s.lastname = uf.lastname;
                    s.email = uf.email;
                    s.address = uf.address;
                    s.countryid = Convert.ToInt32(uf.countryid);
                    s.stateid = Convert.ToInt32(uf.stateid);
                    s.cityid = Convert.ToInt32(uf.cityid);
                    s.number = uf.number.ToString();
                    ts.empstates.AddObject(s);
                    ts.SaveChanges();
                    bool msg = false;
                    return Json(msg);
                }
                else 
                {
                    bool msg = true;
                    return Json(msg);
                }
            }
            catch
            {
                bool msg = true;
                return Json(msg);
                //return View(uf);
            }
        }
        
        //
        // GET: /Home/Edit/5
        public ActionResult Edit(int id = 0)
        {
            userform us = new userform();

            var t = ts.empstates.Where(x => x.id == id).SingleOrDefault();
            var countrylist = ts.countries.ToList();
            us.countries = new SelectList(countrylist, "countryid", "countryname");

            var statelist = ts.states1.Where(x=>x.countryid==t.countryid).ToList();
            us.states = new SelectList(statelist, "stateid", "statename");

            var citylist = ts.city2.Where(x=>x.stateid==t.stateid).ToList();
            us.cities = new SelectList(citylist, "cityid", "cityname");

            us.id = t.id;
            us.firstname = t.firstname;
            us.lastname = t.lastname;
            us.email = t.email;
            us.address = t.address;
            us.countryid = t.countryid.ToString();
            us.stateid = t.stateid.ToString();
            us.cityid = t.cityid.ToString();
            us.number =t.number.ToString();
            return View(us);
        }


        //POST: /Home/Edit/5

        [HttpPost]
        public ActionResult Edit(userform uf)
        {
            var countrylist = ts.countries.ToList();
            uf.countries = new SelectList(countrylist, "countryid", "countryname");

            var statelist = ts.states1.ToList();
            uf.states = new SelectList(statelist, "stateid", "statename");

            var citylist = ts.city2.ToList();
            uf.cities = new SelectList(citylist, "cityid", "cityname");
            try
            {
                var t = ts.empstates.Where(x => x.id == uf.id).SingleOrDefault();
                t.id = uf.id;
                t.firstname = uf.firstname;
                t.lastname = uf.lastname;
                t.email = uf.email;
                t.address = uf.address;
                t.countryid = Convert.ToInt32(uf.countryid);
                t.stateid = Convert.ToInt32(uf.stateid);
                t.cityid = Convert.ToInt32(uf.cityid);
                t.number = uf.number.ToString();
                ts.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(uf);
            }
        }


       
      
        // GET: /Home/Delete/5
 
        public ActionResult Delete(int id)
        {
            var t = ts.empstates.Where(x => x.id == id).SingleOrDefault();
            ts.DeleteObject(t);
            ts.SaveChanges();
            return RedirectToAction("Index");
        }

        //
        // POST: /Home/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public JsonResult setemailid(string email) 
        {
            usercascadEntities ts = new usercascadEntities();
            var t = ts.empstates.Where(x => x.email == email).FirstOrDefault();
            if (t != null)
            {
                return Json("1",JsonRequestBehavior.AllowGet);
            }
            else 
            {
                return Json("0", JsonRequestBehavior.AllowGet);
            }

        }


        public JsonResult GetstateBycountryId(int countryid) 
        {
            List<states1> li = new List<states1>();
            var lblstate = ts.states1.Where(x => x.countryid == countryid).ToList();
            userform f = new userform();
            f.states = new SelectList(lblstate, "stateid", "statename");
            return Json(f.states, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetcityBystateId(int stateid) 
        {
            List<city2> li = new List<city2>();
            var lblcity = ts.city2.Where(x => x.stateid == stateid).ToList();
            userform f = new userform();
            f.cities = new SelectList(lblcity, "cityid", "cityname");
            return Json(f.cities, JsonRequestBehavior.AllowGet);
        }
    }
}
