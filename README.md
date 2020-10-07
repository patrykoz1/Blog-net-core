# Blog-net-core
This is project of my own personal blog. "My own" means - it's developed by me and it's not copy-pasted from tutorial! It's not quite popular among juniors.
Altough it's junior's project it can be used as a real and fully-working piece of code. With some changes I can use it as a site for small business. However - the project has few big bugs (I added them purposely). I don't want someone steal my work and code! If you are a recruter, you see this readme and code just write or call to me I will explain you everything what do you want.

Keywords: .net core mvc,c#, tag helpers,ajax,identity framework, entityframework core


Nice things and features:

-Registration is blocked. Why? This blog is a PERSONAL blog, so we should be sole user and author. I blocked this by few ways - routing, and redirection. Nice to see code!

-Login works ;)

-Seeder is my own. It's impossible to seed database with user and role in OnModelCreating in DbContext. I was forced to make my own DbInitializer class.
-Look at Editing Article feature - there are few well done and interesting things. I use AJAX to load article from DB, I use partial view as well - nice as a trainee!


Things to fix:

-Editing doesn't work (added)

-Deleting doesn't work (EDIT: this feature has been added already)

-I have to spend more time on views, because views look very... poor and ugly (partly done!)

