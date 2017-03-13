<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<dynamic>" %>

<%
    if (Request.IsAuthenticated) {
%>
        <b><%: Page.User.Identity.Name %></b>'s new post.
        <% using (Html.BeginForm()) { %>

        <fieldset>
            <p>
                <label for="Message">Message:</label>
                <%=Html.TextArea("text") %>
                <%=Html.Hidden("author", Page.User.Identity.Name) %>
            </p>
            <p>
                <input type="submit" value="Post"/>
            </p>
        </fieldset>
        
    <% } %>
<%
    }
    else {
%> 
        <p>Log in to post...</p>
        [ <%: Html.ActionLink("Log On", "LogOn", "Account") %> ]
<%
    }
%>
