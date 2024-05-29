using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LtkdLesson06.Models;
using System.ComponentModel.DataAnnotations;

namespace LtkdLesson06.Controllers
{
    public class LtkdSongController : Controller
    {
        private static List<LtkdSong> ltkdSongs = new List<LtkdSong>()
        {
            new LtkdSong {Id=00020,LtkdTitle="Lê Trần Khánh Duy",LtkdAuthor="K22CNT3",LtkdArtist="NTU",LtkdYearRelease=2020 },
            new LtkdSong {Id=1,LtkdTitle="Ha Quoc Thanh",LtkdAuthor="K22CNT3",LtkdArtist="NTU",LtkdYearRelease=2020 }
        };
        
        // GET: LtkdSong
        /// <summary>
        /// Hien Thi danh sach bai hat
        /// Author: Le Tran Khanh Duy
        /// </summary>
        /// <returns></returns>
        public ActionResult LtkdIndex()
        {
            return View(ltkdSongs);
        }

        //Get: LtkdCreate
        /// <summary>
        /// Form them moi bai hat
        /// Author : Le Tran Khanh Duy
        /// </summary>
        /// <returns></returns>

        public ActionResult LtkdCreate()
        {
            var LtkdSong = new LtkdSong();
            return View(LtkdSong);
        }
    }
}