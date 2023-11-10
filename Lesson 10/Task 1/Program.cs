using Task_1;

var builder = WebApplication.CreateBuilder(args);

var meetingRoomSettings = builder.Configuration.GetSection("MeetingRoom").Get<MeetingRoomSetting>();

builder.Services.AddSingleton(new MeetingRoomService(meetingRoomSettings));


// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

app.MapGet("/api/meetingroom/options", (MeetingRoomService meetingRoomService) =>
    {
        return Results.Ok(meetingRoomService.GetMeetingRoomSetting());
    });

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


