using APIServer;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/students/0", GetStudent);

static IResult GetStudent(int number)
{
    List<Students> students =
    [
    new() {Name = "Alex", HitPoints = 100},
    new() {Name = "William", HitPoints = 10},
    new() {Name = "Leonard", HitPoints = 100},
    new() {Name = "Dhani", HitPoints = 100},
    new() {Name = "Hugo", HitPoints = 1},
    new() {Name = "Maxi", HitPoints = 100}
    ];

    if (number < 0 || number >= students.Count)
    {
        return Results.NotFound();
    }

    return Results.Ok(students[number]);
}