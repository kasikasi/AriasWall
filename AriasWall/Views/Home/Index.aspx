<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AriasWall.Models.Post>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Arias WALL
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: ViewData["Message"] %></h2>
    <p>
        Here you can post your thoughts, ideas or even a joke... Be brave!
    </p>
        <% foreach (var item in Model) { %>
        <div class="post"><p><%: item.message %></p>< <i>Posted by <b><%: item.author %></b> on <%: String.Format("{0:D}", item.date) %></i> ></div>
        <% } %>
    
    <br />
    <div id="PostForm">
        <% Html.RenderPartial("_Post_Form"); %>
    </div> 
</asp:Content>
