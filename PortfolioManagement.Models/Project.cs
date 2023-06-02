namespace PortfolioManagement.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public Technology[] Technologies { get; set; }
        public string GithubLink { get; set; }
        public string LiveLink { get; set; }
        public string YouTubeLink { get; set; }
        public DateTime DateAdded { get; set; }
        public Category Category { get; set; }
        public ProjectType ProjectType { get; set; }
        public Branch Branch { get; set; }
    }
}