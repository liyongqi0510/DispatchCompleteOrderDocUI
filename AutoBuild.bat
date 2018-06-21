
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI.WebPart.dll  .\..\..\..\..\..\U9Product\U9.VOB.Product.U9\Portal\\UILib
copy .\bin\Debug\UFIDA.U9.MFG.PFM.DispatchCompleteOrderDocUI.WebPart.pdb  .\..\..\..\..\..\U9Product\U9.VOB.Product.U9\Portal\\UILib

echo begin run build UI Script
echo 目录：.\..\..\..\..\..\U9Product\U9.VOB.Product.Other\\u_ui\UIScript\

echo .\..\..\..\..\..\U9Product\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=ufsoft123;Data Source=zhangjywin7;Initial Catalog=V6MFG20180507001;packet size=4096;Max Pool size=1500;Connection Timeout=150;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\u_ui\UIScript\

echo ui buid end
pause

