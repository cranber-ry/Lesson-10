using RoomSetting;

var builder = WebApplication.CreateBuilder(args);

var meetingRoomSettings = builder.Configuration.GetSection("MeetingRoom").Get<MeetingRoomSetting>();

builder.Services.AddSingleton(new MeetingRoomService(meetingRoomSettings));


// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/api/meetingroom/options", (MeetingRoomService meetingRoomService) =>
{
    return Results.Ok(meetingRoomService.GetMeetingRoomSetting());
});

app.Run();

