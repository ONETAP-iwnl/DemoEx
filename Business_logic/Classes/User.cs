using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Business_logic.Classes
{
    /// <summary>
    /// класс представляющий пользователя системы
    /// </summary>
    public class User: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [Key]
        [JsonProperty("userId")]
        public int UserId { get; private set; }

        [Required]
        [JsonProperty("fio")]
        public string FIO { get; set; }

        [Required]
        [StringLength(11)]
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        [JsonProperty("login")]
        public string Login { get; set; }

        [Required]
        [StringLength(50)]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
