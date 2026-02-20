namespace HealthClinicApp.Utilities
{
    public static class IdGenerator
    {
        private static int _patientId = 1;
        private static int _doctorId = 1;
        private static int _appointmentId = 1;
        private static int _visitId = 1;

        public static int NextPatientId() => _patientId++;
        public static int NextDoctorId() => _doctorId++;
        public static int NextAppointmentId() => _appointmentId++;
        public static int NextVisitId() => _visitId++;
    }
}