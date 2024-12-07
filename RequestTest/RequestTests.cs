using Business_logic.Classes;
using Xunit;

namespace RequestTest
{
    public class RequestTests
    {
        [Fact]
        public void UpdateStatus_ValidStatus_UpdatesStatus()
        {
            // Arrange
            var request = new Request();
            var newStatus = "Completed";

            // Act
            request.UpdateStatus(newStatus);

            // Assert
            Assert.Equal(newStatus, request.RequestStatus);
        }

        [Fact]
        public void AssignMaster_ValidMasterId_AssignsMaster()
        {
            // Arrange
            var request = new Request();
            var masterId = 1;

            // Act
            request.AssignMaster(masterId);

            // Assert
            Assert.Equal(masterId, request.MasterId);
        }
    }
}
