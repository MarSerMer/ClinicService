namespace ClinicService.Models.Requests
{
    public class UpdateConsultationRequest
    {
		public string ConsultationId { get; set; }

		public string ClientId { get; set; }

        public string PetId { get; set; }

        public string ConsultationDate { get; set; }

        public string Description { get; set; }
    }
}
