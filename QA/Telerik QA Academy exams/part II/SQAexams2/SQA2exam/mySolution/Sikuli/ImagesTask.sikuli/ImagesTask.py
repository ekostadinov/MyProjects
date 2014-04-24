#import HTMLTestRunner
from sikuli import *
import unittest, os, sys

bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
#from Lib_with_functions import *

pathBrowser= "C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe"
browserType = "firefox"

patternPath="http://tinyurl.com/qa-academy-siluli"
#patternPath="http://screencast.com/t/omtVib4lV5D"
highlightDuration = 2
patternWidth = 10
patternHeight = patternWidth
moveStep = patternWidth
entirePattern = Pattern("1396585366910.png").similar(0.32)
#Support functions
def waitElement():        
    while not exists(entirePattern):            
        wait(1)
        #reg.Wait(entirePattern)
        
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
#waitElement()
wait(5)
#reg=getRegionFromPSRM(entirePattern)
reg=find(entirePattern)
halfImageSize = reg.getW()/2;
topLeft = reg.getTopLeft()

#declare class
#class TelerikTests(unittest.TestCase):
#define tests cases
#    def TestEqualImgs(self):

#Mark differents
highlight(3.5,0,2,2,1)
highlight(19,25,2,2,0)
highlight(25,27,2,3,0)
highlight(33.5,27,2,3,0)

#HTMLTestRunner Setup
#if __name__ == '__main__':
#    HTMLTestRunner.main()
#Define test suite
#    suite = unittest.TestLoader().loadTestsFromTestCase(TelerikTests)
#    outfile = open("D:\Report.html", "w")
#    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Test Report', description='This is demo' )
#    runner.run(suite)
#suite.addTests(unittest.TestLoader

#Close browser
closeApp("mozilla " + browserType)