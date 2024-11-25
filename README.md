# GameCollectionManagement


A Windows Forms Application for managing and reviewing games. Users can add, edit, search, and filter games, leave reviews, and rate their games. The system includes user authentication, role-based access control, and CRUD operations for games and reviews.  

---

## Features  

### User Management  
- **Registration and Login**: Users can create an account and log in.  
- **User Roles**:  
  - **Admin**: Full access to manage users, games, and reviews.  
  - **Gamer** or **Other User**: Can manage their games and reviews.  
- **Profile Management**: Update user information.  

### Game Management  
- **CRUD Operations**:  
  - **Add**: Add new games with details like title, genre, release date, playtime, and cover image.  
  - **Edit**: Modify existing game details.  
  - **Delete**: Remove games from the system.  
  - **View**: Browse the list of games with advanced filtering and searching options.  

### Game Reviews  
- **Add Reviews**: Users can write reviews for games they own.  
- **Rate Games**: Provide a rating between 1 and 5 for games.  
- **Manage Reviews**:  
  - Edit or delete reviews.  
  - View all reviews for a specific game.  

---

## Technologies Used  
- **C#**: Core language for developing the application.  
- **Windows Forms**: For building the graphical user interface (GUI).  
- **MS SQL Server**: For storing user, game, and review data.  
- **ADO.NET**: Used for database operations, including direct SQL queries, stored procedures, and connections.  


