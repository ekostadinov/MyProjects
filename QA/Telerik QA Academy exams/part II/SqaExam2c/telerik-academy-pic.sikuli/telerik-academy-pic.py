googleIcon = "1403667900762.png"
find(googleIcon)
click(googleIcon)
searchInput = "1403668045184.png"
wait(searchInput, 10)
find(searchInput)
type(searchInput, "telerik academy")
searchBtn = "1403668092799.png"
find(searchBtn)
click(searchBtn)
imagesSearch = Pattern("1403668152024.png").similar(0.95)
wait(5)
click(imagesSearch)
targetImg = "1403668212481.png" 
find(targetImg)
rightClick(targetImg)
copyImgUrl = "1403668398256.png" 
wait(copyImgUrl, 2)
click(copyImgUrl)
newTab = "1403668465010.png"
find(newTab)
click(newTab)
searchInputTab = "1403753573763.png"
wait(searchInputTab, 5)
rightClick(searchInputTab)
pasteBtn = "1403668626947.png"
wait(pasteBtn, 2)
click(pasteBtn)
#send ENTER 
type("1403753887608.png", "\n")
wait("1403753975505.png", 5)
wait(2)
closeBtn = "1403754004945.png"
click(closeBtn)
















                                                                                                                