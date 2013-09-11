namespace Reddit
{
    public class AwwPic
    {
        private readonly string m_Title;
        private readonly string m_Url;

        public AwwPic(string title, string url)
        {
            m_Title = title;
            m_Url = url;
        }

        public string Title
        {
            get { return m_Title; }
        }

        public string Url
        {
            get { return m_Url; }
        }
    }
}