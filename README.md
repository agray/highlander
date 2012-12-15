Highlander
==========

The Highlander - There can be only one

Similar to WIXWriter this tool recurses a specified root directory (that of your web application)

highlander generates 2 files for your aspx project:
Pages.cs - defines a property for
GoTo.cs - exposes getter methods for all pages in Pages.cs and then calls single private method to do the redirection to the target page.

In this way, your application will have ONLY ONE Response.Redirect as GoTo is the gateway for ALL page redirections.

More awesomeness
 - abstract the 'recurse folder' functionality into a single common library to use in both this and WIXWriter