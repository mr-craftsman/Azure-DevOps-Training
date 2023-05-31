<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VolleyballPlayers.aspx.cs" Inherits="WApp1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <p> some text</p>
            <p><%Response.Write(SampleString); %></p>
            <p><% = SampleString %></p>

            <table>
                <tr>
                    <td>Cell 1</td>
                    <td>Cell 2</td>
                    <td>Cell 3</td>
                    <td>Cell 4</td>
                </tr>
            </table>

            <table>
                <%
                    for (int i=0; i<PlayerList.Count; i++)
                    {
                      %>
                        <tr>
                            <td><%=PlayerList[i].id %></td>
                            <td><%=PlayerList[i].firstName %></td>
                            <td><%=PlayerList[i].lastName %></td>
                        </tr>
                      <%
                    }
                 %>
            </table>
            <p>Table 2 </p>
          <table>

            <%

                foreach (var p in PlayerList)
                {

                %>
                      <tr style="background-color:<%= p.HTMLColor %>">
                        <td><%=p.id %></td>
                        <td><%=p.firstName %></td>
                        <td><%=p.lastName %></td>
                    </tr>

            <%  
                }


                %>

        </table>
        </div>
    </form>
</body>
</html>
