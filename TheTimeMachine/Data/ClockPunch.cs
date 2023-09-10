namespace TheTimeMachine.Data
{
    public class ClockPunch
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime UTCPunchDateTime { get; set; }
        public DateTime LocalDateTime => UTCPunchDateTime.ToLocalTime(); // calculated property
        public string? PunchCode { get; set; } // CI or CO
    }
}
