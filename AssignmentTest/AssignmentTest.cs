using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new(TreasureChest.State.Locked);
            // Try to open the chest
            // Verify chest is still locked
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new(TreasureChest.State.Closed);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        [TestMethod]
        public void OpenOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new(TreasureChest.State.Open);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        [TestMethod]
        public void CloseLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new(TreasureChest.State.Locked);
            // Try to close the chest
            // Verify chest is still locked
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void CloseClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new(TreasureChest.State.Closed);
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void CloseOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new(TreasureChest.State.Open);
            chest.Close();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void LockLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new(TreasureChest.State.Locked);
            // Try to lock the chest
            // Verify chest is still locked
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void LockClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new(TreasureChest.State.Closed);
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }

        [TestMethod]
        public void LockOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new(TreasureChest.State.Open);
            chest.Lock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        [TestMethod]
        public void UnlockLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new(TreasureChest.State.Locked);
            // Try to unlock the chest
            // Verify chest is unlocked and in Closed state
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void UnlockClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new(TreasureChest.State.Closed);
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }

        [TestMethod]
        public void UnlockOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new(TreasureChest.State.Open);
            chest.Unlock();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }

        [TestMethod]
        public void ManipulateOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new(TreasureChest.State.Open);

            // Perform close action
            chest.Manipulate(TreasureChest.Action.Close);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);

            // Perform lock action
            chest.Manipulate(TreasureChest.Action.Lock);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);

            // Perform unlock action
            chest.Manipulate(TreasureChest.Action.Unlock);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);

            // Perform open action
            chest.Manipulate(TreasureChest.Action.Open);
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
    }
}
