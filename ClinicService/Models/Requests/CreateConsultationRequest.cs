namespace ClinicService.Models.Requests
{
    public class CreateConsultationRequest
    {
        public string ClientId { get; set; }

        public string PetId { get; set; }

        public string ConsultationDate { get; set; }

        public string Description { get; set; }
    }
}
