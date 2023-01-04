using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspDotNetDemoData
{
    public interface IDataHelper<Table>
    {
        List<Table> GetData();
        List<Table> Search(string SearchItem);
        Table Find (int Id);
        void Add(Table table);
        void Edit(int id,Table table);
        void Delete(int id);
          

    }
}
