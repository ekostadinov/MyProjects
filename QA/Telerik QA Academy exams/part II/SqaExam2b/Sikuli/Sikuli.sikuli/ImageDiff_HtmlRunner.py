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


class ImageDiff_HtmlRunner(unittest.TestCase):
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