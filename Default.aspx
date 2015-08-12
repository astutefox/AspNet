<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Default" %>

<!DOCTYPE html>

<html lang="zh">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />    
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <!--頁面標題-->
            <div class="row">
                <div class="col-md-offset-2 text-center">
                    請購簽核系統
                </div>
            </div>
            <!--功能列-->
            <div class="row">
                <div class="col-md-2">
                    <button id="btnSave">存檔</button>
                    <button id="btnSend">送簽</button>
                </div>
            </div>
            <!--頭檔-->
            <div class="row">
                <div class="col-md-2">部門名稱</div>
                <div class="col-md-2">
                    <input type="text" name="txtDepartment" />
                </div>
                <div class="col-md-2">採購人員</div>
                <div class="col-md-2">
                    <input type="text" name="txtEmployee" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-2">需求日期</div>
                <div class="col-md-2">
                    <input type="text" name="txtRequireDate" />
                </div>
                <div class="col-md-2">供應商</div>
                <div class="col-md-2">
                    <input type="text" name="txtVendor" />
                </div>
            </div>
            <!--尾檔-->
            <div class="row">
                <div class="col-md-offset-2">
                    <table class="table-bordered">
                        <tr>
                            <th>序號</th>
                            <th>料品代號</th>
                            <th>料品名稱</th>
                            <th>數量</th>
                            <th>金額</th>
                            <th>合計</th>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/jquery-1.10.2.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            alert('xd');

        });
    </script>
</body>
</html>
