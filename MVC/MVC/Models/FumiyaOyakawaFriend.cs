using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public enum FriendType
    {
        Conocido,
        CompañeroEstudio,
        ColegaDeTrabajo,
        Amigo,
        AmigoDeInfancia,
        Pariente

    }

    public class FumiyaOyakawaFriend
    {
        [Key]
        public int FriendId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public FriendType Friend { get; set; }
        [Required]
        public DataType Birthdate { get; set; }
    }
}