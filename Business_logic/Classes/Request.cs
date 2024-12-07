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
    public class Request : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [Key]
        [JsonProperty("requestId")]
        public int RequestId { get; private set; }

        [Required]
        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [Required]
        [JsonProperty("homeTechType")]
        public string HomeTechType { get; set; }

        [Required]
        [JsonProperty("homeTechModel")]
        public string HomeTechModel { get; set; }

        [Required]
        [JsonProperty("problemDescription")]
        public string ProblemDescription { get; set; }

        [Required]
        [JsonProperty("requestStatus")]
        public string RequestStatus { get; set; }

        [JsonProperty("completionDate")]
        public DateTime? CompletionDate { get; set; }

        [JsonProperty("repairParts")]
        public string RepairParts { get; set; }

        [JsonProperty("masterId")]
        public int? MasterId { get; set; }

        [JsonProperty("clientId")]
        public int ClientId { get; set; }

        //обновление статуса
        public void UpdateStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                RequestStatus = newStatus;
                OnPropertyChanged(nameof(RequestStatus));
            }
        }
        //назначение мастера
        public void AssignMaster(int masterId)
        {
            MasterId = masterId;
            OnPropertyChanged(nameof(MasterId));
        }
    }
}
