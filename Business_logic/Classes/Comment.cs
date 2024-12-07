using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Business_logic.Classes
{
    /// <summary>
    /// класс представляет комментарии оставленные мастерами
    /// </summary>
    public class Comment : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [Key]
        [JsonProperty("commentId")]
        public int CommentId { get; private set; }

        [Required]
        [JsonProperty("message")]
        public string Message { get; set; }

        [Required]
        [JsonProperty("masterId")]
        public int MasterId { get; set; }

        [Required]
        [JsonProperty("requestId")]
        public int RequestId { get; set; }
    }
}
