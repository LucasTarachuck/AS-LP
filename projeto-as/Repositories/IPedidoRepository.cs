public interface IPedidoRepository
{
    public List<Pedido> GetAll();
    public Pedido GetByID(int id);
    public void Post(Pedido pedido);
    public Pedido Put(int id, Pedido pedidoAtualizado);
    public Pedido delete(int id);
}