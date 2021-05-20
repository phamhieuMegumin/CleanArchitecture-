using Misa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misa.Core.Interfaces.Repository
{

    public interface ICustomerRepository
    {
        /// <summary>
        /// Lấy toàn bộ khách hàng
        /// </summary>
        /// <returns>Danh sách toàn bộ khách hàng</returns>
        IEnumerable<Customer> GetAll();
        /// <summary>
        /// Lấy khách hàng theo ID
        /// </summary>
        /// <param name="customerId">ID của khách hàng</param>
        /// <returns>Khách hàng</returns>
        Customer GetByid(Guid customerId);
        /// <summary>
        /// Thêm mới khách hàng
        /// </summary>
        /// <param name="customer">Dữ liệu khách hàng</param>

        int Insert(Customer customer);
        /// <summary>
        /// Sửa khách hàng
        /// </summary>
        /// <param name="customerId">ID khách hàng cần sửa</param>
        /// <param name="customer">Thông tin khách hàng</param>
        /// <returns></returns>
        int Update(Guid customerId, Customer customer);
        /// <summary>
        /// Xóa khách hàng
        /// </summary>
        /// <param name="customerId">ID khách hàng cần xóa</param>
        /// <returns></returns>
        int Delete(Guid customerId);
    }
}
