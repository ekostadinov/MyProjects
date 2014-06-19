# import a specific class
import HTMLTestRunner
# import multiple libs from specified folder
from sikuli import *
# import list of libs
import unittest, os, sys
# a small 'hack' to add to the classpath the one level up folder- optional, but useful
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
# import all methods and declarations from Lib_with_functions- test
from ImageDifferences import *

class ImageDifferences_HtmlTestRunner(unittest.TestCase):
    def test_001_OpenPatter(self):
        App.open(pathBrowser + " " + patternPath)
        fullSize()
        waitElement()
        reg=getRegionFromPSRM(entirePattern)
        halfImageSize = reg.getW()/2;
        topLeft = reg.getTopLeft()

    def test_002_MarkDiffs(self):
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

    def test_003_CleanUp(self):
        closeApp("mozilla " + browserType)
        
# HTMLTestRunner setup:
if __name__ == '__main__':
    #...define the test suite
    suite = unittest.TestLoader().loadTestsFromTestCase(ImageDifferences_HtmlTestRunner)
    # Uncomment and use that when want to run a single test or 
    # specific subset of tests
    #suite = unittest.TestSuite()
    #suite.addTest(RealWorkUsage('test_001_LoadQSFTest'))

    #...set where to log the results
    outfile = open("C:\Logs\Report.html", "w")
    #...define the runner
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Test Telerik Demo', description='Test the Telerik controls demos, using HTMLTestRunner' )
    #...start the test suite
    runner.run(suite)