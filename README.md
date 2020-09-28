# Blog-net-core
This is project of my own personal blog. "My own" means - it's developed by me and it's not copy-pasted from tutorial! It's not quite popular among juniors.
Altough it's junior's project it can be used as a real and fully-working piece of code. With some changes I can use it as a site for small business.


Nice things and features:

-Registration is blocked. Why? This blog is a PERSONAL blog, so we should be sole user and author. I blocked this by few ways - routing, and redirection. Nice to see code!

-Login works ;)

-Seeder is my own. It's impossible to seed database with user and role in OnModelCreating in DbContext. I was forced to make my own DbInitializer class.


Things to fix:

-Editing doesn't work

-Deleting doesn't work (EDIT: this feature has been added already)

-I have to spend more time on views, because views look very... poor and ugly.

