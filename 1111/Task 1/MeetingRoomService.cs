using Microsoft.Extensions.Options;

namespace Task_1
{
    public class MeetingRoomService
    {
        private readonly MeetingRoomSetting  _setting;

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
