import React, { useContext } from 'react';
import { Menu, Grid } from 'antd';
import { Link } from 'react-router-dom';
import AuthContext from '../../contexts/AuthContext';
const { useBreakpoint } = Grid;

const LeftMenu = () => {
  const { md } = useBreakpoint();
  const { auth } = useContext(AuthContext);

  const items = [
    {
      label: <Link to={'/'}>Home</Link>,
      key: 'home',
    },
    {
      label: <Link to={auth === undefined ? '/' : '/categories'}>Categories</Link>,
      key: 'categories',
    },
    {
      label: <Link to={auth === undefined ? '/' : '/books'}>Books</Link>,
      key: 'books',
    },
    {
      label: <Link to={auth !== undefined && auth?.role === 'SuperUser' ? '/borrow-books' : '/'}>Borrow Books</Link>,
      key: 'borrow-books',
      hidden: auth?.role === 'SuperUser' ? false : true,
    },
  ];
  return <Menu mode={md ? 'horizontal' : 'inline'} items={items} />;
};

export default LeftMenu;
