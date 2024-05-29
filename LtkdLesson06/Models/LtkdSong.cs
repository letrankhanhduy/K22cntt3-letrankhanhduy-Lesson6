using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LtkdLesson06.Models
{
    public class LtkdSong
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage ="Ltkd: Hay nhap tieu de")]
        [DisplayName("Tieu De")]
        public string LtkdTitle { get; set; }
        [Required(ErrorMessage = "Ltkd: Hay nhap tac gia")]
        [DisplayName("Tac Gia")]
        public string LtkdAuthor { get; set; }
        [Required(ErrorMessage = "Ltkd: Hay nhap nghe si")]
        [StringLength (50,MinimumLength =2,ErrorMessage ="Ltkd: Ten nghe si co toi thieu 2 ki tu, toi da 50 ki tu")]
        [DisplayName("Nghe Si")]
        public string LtkdArtist { get; set; }
        [Required(ErrorMessage = "Ltkd: Hay nhap nam xuat ban")]
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="Ltkd: Nam xuat ban phia co 2 ki tu so")]
        [Range(1900,2024,ErrorMessage ="Nam xuat ban trong khoang 1900-2024")]
        [DisplayName("Nam Xuat Ban")]
        public int LtkdYearRelease { get; set; } 

    }
}