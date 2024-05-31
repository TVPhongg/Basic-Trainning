



public class Blog
{
    public int BlogId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public Author Author { get; set; } // Mối quan hệ 1-n: Một blog được viết bởi một tác giả
    public ICollection<Post> Posts { get; set; } // Mối quan hệ 1-n: Một blog có nhiều bài viết
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDate { get; set; }
    public int BlogId { get; set; } // Khóa ngoại, chỉ định blog mà bài viết thuộc về
    public Blog Blog { get; set; } // Mối quan hệ n-1: Một bài viết thuộc về một blog
}

public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public ICollection<Blog> Blogs { get; set; } // Mối quan hệ 1-n: Một tác giả có nhiều blog
}

