



public class EmailTemplateService
{
    public List<EmailTemplate> EmailTemplates = new List<EmailTemplate>();

    public void Add(string subject, string content)
    {
        EmailTemplates.Add(new EmailTemplate() { Subject = subject, Content = content });
    }

    public string GetRegistrationTemplate(string username)
    {
        foreach (var emailTemplate in EmailTemplates)
        {
            if (emailTemplate.Subject.Contains("regis", StringComparison.OrdinalIgnoreCase))
            {
                return emailTemplate.Content.Replace("{{username}}", username);
            }
        }
        return null;
    }
}


public class EmailTemplate
{
    public string Subject { get; set; }
    public string Content { get; set; }
}