dir = "/Users/raimundhocke/Desktop/Sikuli/HTMLTestRunner"
import os
fp = file(os.path.join(dir, "test.html"), "wb")

import unittest
import HTMLTestRunner
reload(HTMLTestRunner)

class MyTest1(unittest.TestCase):
    def test1(self):
        assert False
    def test2(self):
        1/0
        assert True
    def test3(self):
        assert True

class MyTest2(unittest.TestCase):
    def test1(self):
        assert False

suite = unittest.TestLoader().loadTestsFromTestCase(MyTest1)
suite.addTests(unittest.TestLoader().loadTestsFromTestCase(MyTest2))
runner = HTMLTestRunner.HTMLTestRunner(stream = fp, verbosity=2, dirTestScreenshots = dir)
runner.run(suite)
fp.close()

