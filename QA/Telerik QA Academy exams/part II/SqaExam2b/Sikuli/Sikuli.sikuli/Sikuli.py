click("1401159927146.png")
wait(3)
click("1401160123603.png")
wait(1)
type("1401160143400.png", "http://screencast.com/t/FlrpTtmRV" + Key.ENTER)

wait("1401162436830.png")
region1 = Region(232,223,456,398)
region2 = Region(692,229,425,393)
#reuse code for highlighting
def myRectangle(pic):
    diff = find(pic)
    diff.highlight(1)
    wait(0.5)    
pic = "1401161356217.png"
myRectangle(pic)
pic ="1401161464549.png"
myRectangle(pic)
pic ="1401161502991.png"
myRectangle(pic)
pic ="1401161527366.png"
myRectangle(pic)
pic ="1401161562148.png"
myRectangle(pic)
pic ="1401161592512.png"
myRectangle(pic)
pic ="1401161671344.png"
myRectangle(pic)
pic ="1401161699445.png"
myRectangle(pic)
#teardown
click("1401162338069.png")