' 
' Visual Basic.Net Compiler
' Copyright (C) 2004 - 2008 Rolf Bjarne Kvinge, RKvinge@novell.com
' 
' This library is free software; you can redistribute it and/or
' modify it under the terms of the GNU Lesser General Public
' License as published by the Free Software Foundation; either
' version 2.1 of the License, or (at your option) any later version.
' 
' This library is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
' Lesser General Public License for more details.
' 
' You should have received a copy of the GNU Lesser General Public
' License along with this library; if not, write to the Free Software
' Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
' 

Partial Class frmMain

    Friend WithEvents cmnuTest As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuDebugTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuViewCode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuViewCode2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuRunTest As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblBasepath As System.Windows.Forms.Label
    Friend WithEvents dlgBasepath As System.Windows.Forms.FolderBrowserDialog
    Private components As System.ComponentModel.IContainer
    Friend WithEvents lstImages As System.Windows.Forms.ImageList
    Friend WithEvents lblCompiler As System.Windows.Forms.Label
    Friend WithEvents cmdCompiler As System.Windows.Forms.Button
    Friend WithEvents dlgFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdBasepath As System.Windows.Forms.Button

    Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mnuMain = New System.Windows.Forms.MenuStrip
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuViewCode = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToolsRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewQueuedTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lstImages = New System.Windows.Forms.ImageList(Me.components)
        Me.lblBasepath = New System.Windows.Forms.Label
        Me.dlgBasepath = New System.Windows.Forms.FolderBrowserDialog
        Me.cmdBasepath = New System.Windows.Forms.Button
        Me.lblCompiler = New System.Windows.Forms.Label
        Me.cmdCompiler = New System.Windows.Forms.Button
        Me.dlgFile = New System.Windows.Forms.OpenFileDialog
        Me.cmnuTest = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuRunTest = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmnuViewCodeAndDebugTest = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuViewCode2 = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuDebugTest = New System.Windows.Forms.ToolStripMenuItem
        Me.EditThisTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuIldasm = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuIldasmBoth = New System.Windows.Forms.ToolStripMenuItem
        Me.ReflectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VBNCAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VBCAssemblyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BothAssembliesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.CreateNewTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmnuDeleteTest = New System.Windows.Forms.ToolStripMenuItem
        Me.MakeErrorTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdPause = New System.Windows.Forms.Button
        Me.cmdRun = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.lblVBCCompiler = New System.Windows.Forms.Label
        Me.cmdVBCCompiler = New System.Windows.Forms.Button
        Me.cmdReload = New System.Windows.Forms.Button
        Me.cmnuTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RunTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FailedTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SucceededTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotRunTestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RunTestsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateNewTestInThisFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OnlyRefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateKnownFailurestxtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tblLayoutMain = New System.Windows.Forms.TableLayoutPanel
        Me.gridTestProperties = New System.Windows.Forms.PropertyGrid
        Me.txtTestMessage = New System.Windows.Forms.TextBox
        Me.lstTests = New System.Windows.Forms.ListView
        Me.colName = New System.Windows.Forms.ColumnHeader
        Me.colResult = New System.Windows.Forms.ColumnHeader
        Me.colCategory = New System.Windows.Forms.ColumnHeader
        Me.colFailedVerification = New System.Windows.Forms.ColumnHeader
        Me.colDate = New System.Windows.Forms.ColumnHeader
        Me.colKnownFailureReason = New System.Windows.Forms.ColumnHeader
        Me.txtFilter = New System.Windows.Forms.TextBox
        Me.cmbCompiler = New System.Windows.Forms.ComboBox
        Me.cmbVBCCompiler = New System.Windows.Forms.ComboBox
        Me.cmbBasepath = New System.Windows.Forms.ComboBox
        Me.worker = New System.ComponentModel.BackgroundWorker
        Me.cmdSave = New System.Windows.Forms.Button
        Me.barProgress = New rt.EnhancedProgressBar
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tblNumberOfTests = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblTestsRun = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblExecutionTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblAverageExecutionTime = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblTestsNotRun = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblGreenTests = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblRedTests = New System.Windows.Forms.ToolStripStatusLabel
        Me.tblTestsInQueue = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnuMain.SuspendLayout()
        Me.cmnuTest.SuspendLayout()
        Me.cmnuTree.SuspendLayout()
        Me.tblLayoutMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTools})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1066, 24)
        Me.mnuMain.TabIndex = 35
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuViewCode, Me.mnuToolsRefresh, Me.NewTestToolStripMenuItem, Me.ViewQueuedTestsToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(44, 20)
        Me.mnuTools.Text = "Tools"
        '
        'cmnuViewCode
        '
        Me.cmnuViewCode.Name = "cmnuViewCode"
        Me.cmnuViewCode.Size = New System.Drawing.Size(173, 22)
        Me.cmnuViewCode.Text = "View code"
        '
        'mnuToolsRefresh
        '
        Me.mnuToolsRefresh.Name = "mnuToolsRefresh"
        Me.mnuToolsRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.mnuToolsRefresh.Size = New System.Drawing.Size(173, 22)
        Me.mnuToolsRefresh.Text = "&Refresh"
        '
        'NewTestToolStripMenuItem
        '
        Me.NewTestToolStripMenuItem.Name = "NewTestToolStripMenuItem"
        Me.NewTestToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewTestToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NewTestToolStripMenuItem.Text = "New test"
        '
        'ViewQueuedTestsToolStripMenuItem
        '
        Me.ViewQueuedTestsToolStripMenuItem.Name = "ViewQueuedTestsToolStripMenuItem"
        Me.ViewQueuedTestsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ViewQueuedTestsToolStripMenuItem.Text = "View queued tests"
        '
        'lstImages
        '
        Me.lstImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.lstImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.lstImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'lblBasepath
        '
        Me.lblBasepath.Location = New System.Drawing.Point(9, 31)
        Me.lblBasepath.Name = "lblBasepath"
        Me.lblBasepath.Size = New System.Drawing.Size(100, 21)
        Me.lblBasepath.TabIndex = 5
        Me.lblBasepath.Text = "Tests:"
        '
        'dlgBasepath
        '
        Me.dlgBasepath.ShowNewFolderButton = False
        '
        'cmdBasepath
        '
        Me.cmdBasepath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdBasepath.Location = New System.Drawing.Point(1039, 27)
        Me.cmdBasepath.Name = "cmdBasepath"
        Me.cmdBasepath.Size = New System.Drawing.Size(25, 21)
        Me.cmdBasepath.TabIndex = 6
        Me.cmdBasepath.Text = "..."
        '
        'lblCompiler
        '
        Me.lblCompiler.Location = New System.Drawing.Point(9, 55)
        Me.lblCompiler.Name = "lblCompiler"
        Me.lblCompiler.Size = New System.Drawing.Size(100, 21)
        Me.lblCompiler.TabIndex = 8
        Me.lblCompiler.Text = "VBNC Compiler:"
        '
        'cmdCompiler
        '
        Me.cmdCompiler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCompiler.Location = New System.Drawing.Point(1039, 55)
        Me.cmdCompiler.Name = "cmdCompiler"
        Me.cmdCompiler.Size = New System.Drawing.Size(25, 21)
        Me.cmdCompiler.TabIndex = 9
        Me.cmdCompiler.Text = "..."
        '
        'dlgFile
        '
        Me.dlgFile.Filter = "Executable files (*.exe)|*.exe|All files (*.*)|*.*"
        Me.dlgFile.Title = "Select the compiler to use"
        '
        'cmnuTest
        '
        Me.cmnuTest.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuRunTest, Me.ToolStripSeparator1, Me.cmnuViewCodeAndDebugTest, Me.cmnuViewCode2, Me.cmnuDebugTest, Me.EditThisTestToolStripMenuItem, Me.ToolStripSeparator3, Me.mnuIldasm, Me.ReflectToolStripMenuItem, Me.ToolStripSeparator2, Me.CreateNewTestToolStripMenuItem, Me.cmnuDeleteTest, Me.MakeErrorTestToolStripMenuItem})
        Me.cmnuTest.Name = "cmnuTest"
        Me.cmnuTest.Size = New System.Drawing.Size(379, 242)
        '
        'cmnuRunTest
        '
        Me.cmnuRunTest.Name = "cmnuRunTest"
        Me.cmnuRunTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuRunTest.Text = "Run this test"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(375, 6)
        '
        'cmnuViewCodeAndDebugTest
        '
        Me.cmnuViewCodeAndDebugTest.Name = "cmnuViewCodeAndDebugTest"
        Me.cmnuViewCodeAndDebugTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuViewCodeAndDebugTest.Text = "&View Code (external editor) and Set this test to be debugged"
        '
        'cmnuViewCode2
        '
        Me.cmnuViewCode2.Name = "cmnuViewCode2"
        Me.cmnuViewCode2.Size = New System.Drawing.Size(378, 22)
        Me.cmnuViewCode2.Text = "View code (external editor)"
        '
        'cmnuDebugTest
        '
        Me.cmnuDebugTest.Name = "cmnuDebugTest"
        Me.cmnuDebugTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuDebugTest.Text = "&Set this test to be debugged"
        '
        'EditThisTestToolStripMenuItem
        '
        Me.EditThisTestToolStripMenuItem.Name = "EditThisTestToolStripMenuItem"
        Me.EditThisTestToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.EditThisTestToolStripMenuItem.Text = "Edit this test (internal editor)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(375, 6)
        '
        'mnuIldasm
        '
        Me.mnuIldasm.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIldasmBoth})
        Me.mnuIldasm.Name = "mnuIldasm"
        Me.mnuIldasm.Size = New System.Drawing.Size(378, 22)
        Me.mnuIldasm.Text = "Ildasm"
        '
        'mnuIldasmBoth
        '
        Me.mnuIldasmBoth.Name = "mnuIldasmBoth"
        Me.mnuIldasmBoth.Size = New System.Drawing.Size(161, 22)
        Me.mnuIldasmBoth.Text = "Both assemblies"
        '
        'ReflectToolStripMenuItem
        '
        Me.ReflectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VBNCAssemblyToolStripMenuItem, Me.VBCAssemblyToolStripMenuItem, Me.BothAssembliesToolStripMenuItem})
        Me.ReflectToolStripMenuItem.Name = "ReflectToolStripMenuItem"
        Me.ReflectToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.ReflectToolStripMenuItem.Text = "Reflect"
        '
        'VBNCAssemblyToolStripMenuItem
        '
        Me.VBNCAssemblyToolStripMenuItem.Name = "VBNCAssemblyToolStripMenuItem"
        Me.VBNCAssemblyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VBNCAssemblyToolStripMenuItem.Text = "VBNC assembly"
        '
        'VBCAssemblyToolStripMenuItem
        '
        Me.VBCAssemblyToolStripMenuItem.Name = "VBCAssemblyToolStripMenuItem"
        Me.VBCAssemblyToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.VBCAssemblyToolStripMenuItem.Text = "VBC assembly"
        '
        'BothAssembliesToolStripMenuItem
        '
        Me.BothAssembliesToolStripMenuItem.Name = "BothAssembliesToolStripMenuItem"
        Me.BothAssembliesToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.BothAssembliesToolStripMenuItem.Text = "Both assemblies"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(375, 6)
        '
        'CreateNewTestToolStripMenuItem
        '
        Me.CreateNewTestToolStripMenuItem.Name = "CreateNewTestToolStripMenuItem"
        Me.CreateNewTestToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.CreateNewTestToolStripMenuItem.Text = "Create new test"
        '
        'cmnuDeleteTest
        '
        Me.cmnuDeleteTest.Name = "cmnuDeleteTest"
        Me.cmnuDeleteTest.Size = New System.Drawing.Size(378, 22)
        Me.cmnuDeleteTest.Text = "Delete test"
        '
        'MakeErrorTestToolStripMenuItem
        '
        Me.MakeErrorTestToolStripMenuItem.Name = "MakeErrorTestToolStripMenuItem"
        Me.MakeErrorTestToolStripMenuItem.Size = New System.Drawing.Size(378, 22)
        Me.MakeErrorTestToolStripMenuItem.Text = "Make error test"
        '
        'cmdPause
        '
        Me.cmdPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPause.Location = New System.Drawing.Point(989, 157)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 25)
        Me.cmdPause.TabIndex = 20
        Me.cmdPause.Tag = ""
        Me.cmdPause.Text = "Pause"
        '
        'cmdRun
        '
        Me.cmdRun.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdRun.Location = New System.Drawing.Point(989, 126)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 25)
        Me.cmdRun.TabIndex = 27
        Me.cmdRun.Tag = ""
        Me.cmdRun.Text = "Run all tests"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(989, 601)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 25)
        Me.cmdExit.TabIndex = 28
        Me.cmdExit.Tag = ""
        Me.cmdExit.Text = "&Exit"
        '
        'cmdStop
        '
        Me.cmdStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdStop.Location = New System.Drawing.Point(989, 188)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 25)
        Me.cmdStop.TabIndex = 29
        Me.cmdStop.Tag = ""
        Me.cmdStop.Text = "Stop"
        '
        'lblVBCCompiler
        '
        Me.lblVBCCompiler.Location = New System.Drawing.Point(9, 82)
        Me.lblVBCCompiler.Name = "lblVBCCompiler"
        Me.lblVBCCompiler.Size = New System.Drawing.Size(100, 21)
        Me.lblVBCCompiler.TabIndex = 36
        Me.lblVBCCompiler.Text = "VBC Compiler:"
        '
        'cmdVBCCompiler
        '
        Me.cmdVBCCompiler.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdVBCCompiler.Location = New System.Drawing.Point(1039, 82)
        Me.cmdVBCCompiler.Name = "cmdVBCCompiler"
        Me.cmdVBCCompiler.Size = New System.Drawing.Size(25, 21)
        Me.cmdVBCCompiler.TabIndex = 38
        Me.cmdVBCCompiler.Text = "..."
        '
        'cmdReload
        '
        Me.cmdReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdReload.Location = New System.Drawing.Point(989, 338)
        Me.cmdReload.Name = "cmdReload"
        Me.cmdReload.Size = New System.Drawing.Size(75, 25)
        Me.cmdReload.TabIndex = 39
        Me.cmdReload.Tag = ""
        Me.cmdReload.Text = "&Reload list"
        '
        'cmnuTree
        '
        Me.cmnuTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunTestsToolStripMenuItem, Me.CreateNewTestInThisFolderToolStripMenuItem, Me.OnlyRefreshToolStripMenuItem, Me.CreateKnownFailurestxtToolStripMenuItem})
        Me.cmnuTree.Name = "cmnuTree"
        Me.cmnuTree.Size = New System.Drawing.Size(226, 92)
        '
        'RunTestsToolStripMenuItem
        '
        Me.RunTestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllTestsToolStripMenuItem, Me.FailedTestsToolStripMenuItem, Me.SucceededTestsToolStripMenuItem, Me.NotRunTestsToolStripMenuItem, Me.RunTestsToolStripMenuItem1})
        Me.RunTestsToolStripMenuItem.Name = "RunTestsToolStripMenuItem"
        Me.RunTestsToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.RunTestsToolStripMenuItem.Text = "&Run tests"
        '
        'AllTestsToolStripMenuItem
        '
        Me.AllTestsToolStripMenuItem.Name = "AllTestsToolStripMenuItem"
        Me.AllTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AllTestsToolStripMenuItem.Text = "&All tests"
        '
        'FailedTestsToolStripMenuItem
        '
        Me.FailedTestsToolStripMenuItem.Name = "FailedTestsToolStripMenuItem"
        Me.FailedTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.FailedTestsToolStripMenuItem.Text = "&Failed tests"
        '
        'SucceededTestsToolStripMenuItem
        '
        Me.SucceededTestsToolStripMenuItem.Name = "SucceededTestsToolStripMenuItem"
        Me.SucceededTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SucceededTestsToolStripMenuItem.Text = "&Succeeded tests"
        '
        'NotRunTestsToolStripMenuItem
        '
        Me.NotRunTestsToolStripMenuItem.Name = "NotRunTestsToolStripMenuItem"
        Me.NotRunTestsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NotRunTestsToolStripMenuItem.Text = "&Not run tests"
        '
        'RunTestsToolStripMenuItem1
        '
        Me.RunTestsToolStripMenuItem1.Name = "RunTestsToolStripMenuItem1"
        Me.RunTestsToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.RunTestsToolStripMenuItem1.Text = "&Run tests"
        '
        'CreateNewTestInThisFolderToolStripMenuItem
        '
        Me.CreateNewTestInThisFolderToolStripMenuItem.Name = "CreateNewTestInThisFolderToolStripMenuItem"
        Me.CreateNewTestInThisFolderToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CreateNewTestInThisFolderToolStripMenuItem.Text = "Create new test in this folder"
        '
        'OnlyRefreshToolStripMenuItem
        '
        Me.OnlyRefreshToolStripMenuItem.Name = "OnlyRefreshToolStripMenuItem"
        Me.OnlyRefreshToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.OnlyRefreshToolStripMenuItem.Text = "Only refresh"
        '
        'CreateKnownFailurestxtToolStripMenuItem
        '
        Me.CreateKnownFailurestxtToolStripMenuItem.Name = "CreateKnownFailurestxtToolStripMenuItem"
        Me.CreateKnownFailurestxtToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.CreateKnownFailurestxtToolStripMenuItem.Text = "Create KnownFailures.txt"
        '
        'tblLayoutMain
        '
        Me.tblLayoutMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblLayoutMain.ColumnCount = 1
        Me.tblLayoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblLayoutMain.Controls.Add(Me.gridTestProperties, 0, 2)
        Me.tblLayoutMain.Controls.Add(Me.txtTestMessage, 0, 2)
        Me.tblLayoutMain.Controls.Add(Me.lstTests, 0, 0)
        Me.tblLayoutMain.Controls.Add(Me.txtFilter, 0, 1)
        Me.tblLayoutMain.Location = New System.Drawing.Point(12, 106)
        Me.tblLayoutMain.Name = "tblLayoutMain"
        Me.tblLayoutMain.RowCount = 3
        Me.tblLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tblLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblLayoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblLayoutMain.Size = New System.Drawing.Size(972, 488)
        Me.tblLayoutMain.TabIndex = 35
        '
        'gridTestProperties
        '
        Me.gridTestProperties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridTestProperties.HelpVisible = False
        Me.gridTestProperties.Location = New System.Drawing.Point(3, 260)
        Me.gridTestProperties.Name = "gridTestProperties"
        Me.gridTestProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
        Me.gridTestProperties.Size = New System.Drawing.Size(966, 109)
        Me.gridTestProperties.TabIndex = 35
        Me.gridTestProperties.ToolbarVisible = False
        '
        'txtTestMessage
        '
        Me.txtTestMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTestMessage.BackColor = System.Drawing.Color.White
        Me.txtTestMessage.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTestMessage.Location = New System.Drawing.Point(3, 375)
        Me.txtTestMessage.Multiline = True
        Me.txtTestMessage.Name = "txtTestMessage"
        Me.txtTestMessage.ReadOnly = True
        Me.txtTestMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTestMessage.Size = New System.Drawing.Size(966, 110)
        Me.txtTestMessage.TabIndex = 9
        Me.txtTestMessage.WordWrap = False
        '
        'lstTests
        '
        Me.lstTests.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colResult, Me.colCategory, Me.colFailedVerification, Me.colDate, Me.colKnownFailureReason})
        Me.lstTests.ContextMenuStrip = Me.cmnuTest
        Me.lstTests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstTests.FullRowSelect = True
        Me.lstTests.HideSelection = False
        Me.lstTests.LargeImageList = Me.lstImages
        Me.lstTests.Location = New System.Drawing.Point(3, 3)
        Me.lstTests.Name = "lstTests"
        Me.lstTests.Size = New System.Drawing.Size(966, 224)
        Me.lstTests.SmallImageList = Me.lstImages
        Me.lstTests.StateImageList = Me.lstImages
        Me.lstTests.TabIndex = 33
        Me.lstTests.UseCompatibleStateImageBehavior = False
        Me.lstTests.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Name = "colName"
        Me.colName.Text = "Name"
        Me.colName.Width = 80
        '
        'colResult
        '
        Me.colResult.Text = "Result"
        Me.colResult.Width = 80
        '
        'colCategory
        '
        Me.colCategory.Text = "Category"
        Me.colCategory.Width = 83
        '
        'colFailedVerification
        '
        Me.colFailedVerification.Text = "Failed Verification"
        Me.colFailedVerification.Width = 249
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 80
        '
        'colKnownFailureReason
        '
        Me.colKnownFailureReason.Text = "Known Failure Reason"
        Me.colKnownFailureReason.Width = 148
        '
        'txtFilter
        '
        Me.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFilter.Location = New System.Drawing.Point(3, 233)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(966, 21)
        Me.txtFilter.TabIndex = 36
        '
        'cmbCompiler
        '
        Me.cmbCompiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCompiler.FormattingEnabled = True
        Me.cmbCompiler.Location = New System.Drawing.Point(129, 55)
        Me.cmbCompiler.Name = "cmbCompiler"
        Me.cmbCompiler.Size = New System.Drawing.Size(904, 21)
        Me.cmbCompiler.TabIndex = 19
        '
        'cmbVBCCompiler
        '
        Me.cmbVBCCompiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbVBCCompiler.FormattingEnabled = True
        Me.cmbVBCCompiler.Location = New System.Drawing.Point(129, 82)
        Me.cmbVBCCompiler.Name = "cmbVBCCompiler"
        Me.cmbVBCCompiler.Size = New System.Drawing.Size(904, 21)
        Me.cmbVBCCompiler.TabIndex = 37
        '
        'cmbBasepath
        '
        Me.cmbBasepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBasepath.FormattingEnabled = True
        Me.cmbBasepath.Location = New System.Drawing.Point(129, 28)
        Me.cmbBasepath.Name = "cmbBasepath"
        Me.cmbBasepath.Size = New System.Drawing.Size(904, 21)
        Me.cmbBasepath.TabIndex = 18
        '
        'worker
        '
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(989, 369)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 25)
        Me.cmdSave.TabIndex = 44
        Me.cmdSave.Tag = ""
        Me.cmdSave.Text = "&Save list"
        '
        'barProgress
        '
        Me.barProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.barProgress.Location = New System.Drawing.Point(12, 608)
        Me.barProgress.Name = "barProgress"
        Me.barProgress.Size = New System.Drawing.Size(973, 27)
        Me.barProgress.TabIndex = 0
        Me.barProgress.ValueCount = 3
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tblNumberOfTests, Me.tblTestsRun, Me.tblExecutionTime, Me.tblAverageExecutionTime, Me.tblTestsNotRun, Me.tblGreenTests, Me.tblRedTests, Me.tblTestsInQueue})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 645)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1066, 22)
        Me.StatusStrip1.TabIndex = 45
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tblNumberOfTests
        '
        Me.tblNumberOfTests.Name = "tblNumberOfTests"
        Me.tblNumberOfTests.Size = New System.Drawing.Size(111, 17)
        Me.tblNumberOfTests.Text = "ToolStripStatusLabel1"
        '
        'tblTestsRun
        '
        Me.tblTestsRun.Name = "tblTestsRun"
        Me.tblTestsRun.Size = New System.Drawing.Size(111, 17)
        Me.tblTestsRun.Text = "ToolStripStatusLabel1"
        '
        'tblExecutionTime
        '
        Me.tblExecutionTime.Name = "tblExecutionTime"
        Me.tblExecutionTime.Size = New System.Drawing.Size(111, 17)
        Me.tblExecutionTime.Text = "ToolStripStatusLabel1"
        '
        'tblAverageExecutionTime
        '
        Me.tblAverageExecutionTime.Name = "tblAverageExecutionTime"
        Me.tblAverageExecutionTime.Size = New System.Drawing.Size(111, 17)
        Me.tblAverageExecutionTime.Text = "ToolStripStatusLabel1"
        '
        'tblTestsNotRun
        '
        Me.tblTestsNotRun.Name = "tblTestsNotRun"
        Me.tblTestsNotRun.Size = New System.Drawing.Size(111, 17)
        Me.tblTestsNotRun.Text = "ToolStripStatusLabel1"
        '
        'tblGreenTests
        '
        Me.tblGreenTests.Name = "tblGreenTests"
        Me.tblGreenTests.Size = New System.Drawing.Size(111, 17)
        Me.tblGreenTests.Text = "ToolStripStatusLabel1"
        '
        'tblRedTests
        '
        Me.tblRedTests.Name = "tblRedTests"
        Me.tblRedTests.Size = New System.Drawing.Size(111, 17)
        Me.tblRedTests.Text = "ToolStripStatusLabel1"
        '
        'tblTestsInQueue
        '
        Me.tblTestsInQueue.Name = "tblTestsInQueue"
        Me.tblTestsInQueue.Size = New System.Drawing.Size(111, 17)
        Me.tblTestsInQueue.Text = "ToolStripStatusLabel1"
        '
        'frmMain
        '
        Me.ClientSize = New System.Drawing.Size(1066, 667)
        Me.Controls.Add(Me.tblLayoutMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmbCompiler)
        Me.Controls.Add(Me.cmbVBCCompiler)
        Me.Controls.Add(Me.cmdVBCCompiler)
        Me.Controls.Add(Me.cmdReload)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.lblVBCCompiler)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmbBasepath)
        Me.Controls.Add(Me.barProgress)
        Me.Controls.Add(Me.lblCompiler)
        Me.Controls.Add(Me.cmdCompiler)
        Me.Controls.Add(Me.lblBasepath)
        Me.Controls.Add(Me.cmdBasepath)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Regression Tester"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.cmnuTest.ResumeLayout(False)
        Me.cmnuTree.ResumeLayout(False)
        Me.tblLayoutMain.ResumeLayout(False)
        Me.tblLayoutMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuToolsRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbBasepath As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCompiler As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents cmdRun As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents barProgress As rt.EnhancedProgressBar
    Friend WithEvents cmnuViewCodeAndDebugTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVBCCompiler As System.Windows.Forms.Label
    Friend WithEvents cmbVBCCompiler As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVBCCompiler As System.Windows.Forms.Button
    Friend WithEvents cmdReload As System.Windows.Forms.Button
    Friend WithEvents CreateNewTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditThisTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReflectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBNCAssemblyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VBCAssemblyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BothAssembliesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstTests As System.Windows.Forms.ListView
    Friend WithEvents colName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colResult As System.Windows.Forms.ColumnHeader
    Friend WithEvents colFailedVerification As System.Windows.Forms.ColumnHeader
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmnuTree As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FailedTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucceededTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CreateNewTestInThisFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewQueuedTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotRunTestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunTestsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlyRefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colCategory As System.Windows.Forms.ColumnHeader
    Friend WithEvents worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents MakeErrorTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateKnownFailurestxtToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIldasm As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIldasmBoth As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmnuDeleteTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtTestMessage As System.Windows.Forms.TextBox
    Friend WithEvents colKnownFailureReason As System.Windows.Forms.ColumnHeader
    Friend WithEvents tblLayoutMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tblNumberOfTests As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblTestsRun As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblExecutionTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblAverageExecutionTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblTestsNotRun As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblGreenTests As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblRedTests As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tblTestsInQueue As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents gridTestProperties As System.Windows.Forms.PropertyGrid
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
End Class
