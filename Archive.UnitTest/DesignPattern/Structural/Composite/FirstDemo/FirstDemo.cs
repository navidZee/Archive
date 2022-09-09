using Archive.CSharp.DesignPattern.Structural.Composite.FirstDemo;
using Xunit;
using myComposite = Archive.CSharp.DesignPattern.Structural.Composite.FirstDemo.Composite;

namespace Archive.UnitTest.DesignPattern.Structural.Composite.FirstDemo
{
    public class FirstDemo
    {
        [Fact]
        public void Composite_ShouldPresentProperly()
        {
            myComposite root = new myComposite("root");
            root.Add(new Leaf("Leaf-A"));
            root.Add(new Leaf("Leaf-B"));

            myComposite composite = new myComposite("Composite-X");
            composite.Add(new Leaf("Leaf-XA"));
            composite.Add(new Leaf("Leaf-XB"));

            root.Add(composite);
            root.Add(new Leaf("Leaf-C"));

            root.Display(22);
/* ShouldBe
    -root
    ---Leaf A
    ---Leaf B
    ---Composite X
    -----Leaf XA
    -----Leaf XB
    ---Leaf C
*/
        }
    }
}
