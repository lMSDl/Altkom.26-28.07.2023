namespace DP.DesignPatterns.Creational.ObjectPool
{
    internal class Client
    {


        public static void Execute()
        {
            /*var counter = 0;
            while(true)
            {
                if( counter > 1000)
                {
                    Thread.Sleep(1);
                    continue;
                }

                var item = new Item();
                item.IsVisible= true;
                Task.Delay(100).ContinueWith(t => { item.IsVisible = false; Interlocked.Decrement(ref counter); });
                Interlocked.Increment(ref counter);
            }*/

            /*var itemPool = new ItemPool(1000);
            while (true)
            {
                var item = itemPool.Acquire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }

                Task.Delay(100).ContinueWith(t => { item.IsVisible = false; });
            }*/

            var objectPool = new ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                var item = objectPool.Acuire();
                if (item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }


                item.IsVisible = true;
                Task.Delay(100).ContinueWith(t => { item.IsVisible = false; objectPool.Release(item); });
            }
        }

    }
}
