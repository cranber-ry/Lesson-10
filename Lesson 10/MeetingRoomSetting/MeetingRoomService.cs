namespace RoomSetting
{
    public class MeetingRoomService
    {
        private readonly MeetingRoomSetting _setting;

        public MeetingRoomService(MeetingRoomSetting setting)
        {

            _setting = setting;
        }

        public MeetingRoomSetting GetMeetingRoomSetting()
        {
            return _setting;
        }
    }
}
