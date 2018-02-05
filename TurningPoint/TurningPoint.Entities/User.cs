using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurningPoint.Entities
{
    [Table("User")]
    public class User
    {

        [Key]
        [Column("UserID")]
        public int UserID { get; set; }

        [Column("UserFirstName")]
        public string UserFirstName { get; set; }

        [Column("UserLastName")]
        public string UserLastName { get; set; }

        [Column("UserEmail")]
        public string UserEmail { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("UserRoles")]
        public string UserRoles { get; set; }
    }
}
