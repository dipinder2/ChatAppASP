using System.Diagnostics.CodeAnalysis;

namespace WebApplication2.Models;

public class Message
{
    public int Id { get; set; }
    [NotNull]
    public string? Body { get; set; }
    public DateTime PostedOn { get; set; } = DateTime.Now;
}

