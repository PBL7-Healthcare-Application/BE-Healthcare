using BE_Healthcare.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_Healthcare.Models
{
    public class TimeOffModel : InformationTimeOffModel
    {
        public int IdTimeOff { get; set; }

    }
}
