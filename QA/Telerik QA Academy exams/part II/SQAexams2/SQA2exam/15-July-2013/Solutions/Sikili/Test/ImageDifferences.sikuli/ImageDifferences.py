from sikuli import *
import unittest, os, sys

bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)

pathBrowser= "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe"
browserType = "firefox"
patternPath="http://tinyurl.com/qa-academy-siluli"
#patternPath="http://screencast.com/t/omtVib4lV5D"
highlightDuration = 2
patternWidth = 20
patternHeight = patternWidth
moveStep = patternWidth
entirePattern = "Cy1qnzIvsvmm.png"

fullSizeImage = "fullsize-1.png"

#Support functions
def waitElement():
    while not exists(entirePattern):
        wait(1)

def fullSize():
    if exists(fullSizeImage):
       click(fullSizeImage)
        

def highlight(Right,Below,Height, Width, Reinit):
    reg.setH(patternHeight * Height)
    reg.setW(patternWidth * Width)
    newLocation = Location(topLeft.x + Right * moveStep , topLeft.y + Below * moveStep) 
    reg.moveTo(newLocation)
    #Highlight left image
    reg.highlight(highlightDuration)
    #Highlight right image
    rightLocation = Location(topLeft.x + halfImageSize + Right * moveStep , topLeft.y + Below * moveStep) 
    reg.moveTo(rightLocation)
    reg.highlight(highlightDuration)

#Open pattern
App.open(pathBrowser + " " + patternPath)
fullSize()
#waitElement()
wait(10)
reg=getRegionFromPSRM(entirePattern)
halfImageSize = reg.getW()/2;
topLeft = reg.getTopLeft()

#Mark differents
highlight(5,0,2,2,1)
#highlight(6,2,2,2,0)
#highlight(35,0,2,3,0)
#highlight(27,15,2,3,0)
#highlight(15,18,3,5,0)
#highlight(20,19,2,2,0)
#highlight(2,25,2,2,0)
#highlight(20,25,2,2,0)
#highlight(19.5,27,2,2,0)
#highlight(26,27,2,2,0)
#highlight(34,27,2,2,0)

#Close browser
closeApp("mozilla " + browserType)

