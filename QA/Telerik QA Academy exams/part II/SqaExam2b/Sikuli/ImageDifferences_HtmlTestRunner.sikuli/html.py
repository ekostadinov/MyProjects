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
from exam1 import *

class HTMLRunnerUsage(unittest.TestCase):
    def test_001_LoadQSFTest(self):
        sleep(1)
        
      
# HTMLTestRunner setup:
if __name__ == '__main__':
    #...define the test suite
    suite = unittest.TestLoader().loadTestsFromTestCase(HTMLRunnerUsage)
    # Uncomment and use that when want to run a single test or 
    # specific subset of tests
    #suite = unittest.TestSuite()
    #suite.addTest(RealWorkUsage('test_001_LoadQSFTest'))

    #...set where to log the results
    outfile = open("C:\Sikuli\exam1.sikuli\Report.html", "w")
    #...define the runner
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Test Telerik Demo', description='Test the Telerik controls demos, using HTMLTestRunner' )
    #...start the test suite
    runner.run(suite)