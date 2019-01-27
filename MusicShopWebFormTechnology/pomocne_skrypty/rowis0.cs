if (dt.Rows.Length > 0)
    soptype = dt.Rows[0]["SOPTYPE"].ToString();
else
    somethingWentWrong();
	
	
	
	<asp:Panel ID="bsKomunikatCzyIstniejeTakiUser" runat="server">
                    <p style="text-align:center;">Komunikat!!! -Nie ma takiego uzytkownika</p>
                </asp:Panel>