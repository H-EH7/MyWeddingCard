using MyWeddingCard.Models;

namespace MyWeddingCard.Repositorys
{
    public interface IPostRepository
    {
        /// <summary>
        /// CREATE
        /// </summary>
        /// <param name="post">new Post</param>
        /// <returns>Created Post</returns>
        public Post post(Post post);

        /// <summary>
        /// READ
        /// </summary>
        /// <param name="id">Post id</param>
        /// <returns>Found Post</returns>
        public Post findPost(int id);

        /// <summary>
        /// READ ALL
        /// </summary>
        /// <returns>Found Post List</returns>
        public List<Post> findAllPosts();

        /// <summary>
        /// DELETE
        /// </summary>
        /// <param name="id">Post id</param>
        /// <returns>Deleted Post</returns>
        public Post deletePost(int id);
    }
}
