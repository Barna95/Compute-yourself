import Logo from '../assets/logo.svg';
import React from 'react'

const mystyle = {
  width:'40%',
  height:'40%'
};

export default function home() {
  return (
    <img style={mystyle} src={Logo} alt="Logo" />
  )
}
