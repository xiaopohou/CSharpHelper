﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Ninesky.IDAL
{
    public interface InterfaceBaseRepository<T> where T : class, new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>添加后的实体</returns>
        T Add(T entity);

        /// <summary>
        /// 查询记录数
        /// </summary>
        /// <param name="predicate">Expression将强类型lambda表达式表示为数据结构，Func封装一个委托值的方法</param>
        /// <returns>记录数</returns>
        int Count(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>是否成功</returns>
        bool Delete(T entity);

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <param name="anyLambda">查询表达式</param>
        /// <returns>是否存在</returns>
        bool Exist(Expression<Func<T, bool>> anyLambda);

        /// <summary>
        /// 查询数据
        /// </summary>
        /// <param name="whereLambda">查询表达式</param>
        /// <returns>实体</returns>
        T Find(Expression<Func<T, bool>> whereLambda);

        /// <summary>
        /// 查询数据列表
        /// </summary>
        /// <typeparam name="S">排序</typeparam>
        /// <param name="whereLamdba">查询表达式</param>
        /// <param name="isAsc">是否升序</param>
        /// <param name="orderLambda">排序表达式</param>
        /// <returns></returns>
        IQueryable<T> FindList(Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc);

        /// <summary>
        /// 查询分页数据
        /// </summary>
        /// </summary>
        /// <typeparam name="S">排序</typeparam>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="totalRecord">总记录数</param>
        /// <param name="whereLamdba">查询表达式</param>
        /// <param name="isAsc">是否升序</param>
        /// <param name="orderLamdba">排序表达式</param>
        /// <returns></returns>
        IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> whereLamdba, string orderName, bool isAsc);
    }
}