namespace UserLogin      // Cyclomatic Complexity = 4 + 1 = 5

{
    public enum UserRole
    {
        Student,
        LibraryStaff,
        LegalStaff,
        Admin
    }

    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public UserRole Role { get; set; }

        // NOTE: For this exercise we store a plain-text Password property so tests can set it.
        // In real applications never store plain-text passwords.
        public string Password { get; set; } = string.Empty;

        public bool IsLoggedIn { get; private set; }

        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return false;

            if (username == Name && password == Password)
            {
                IsLoggedIn = true;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            IsLoggedIn = false;
        }
    }
}
