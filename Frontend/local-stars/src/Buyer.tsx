import React from 'react'
import {Grid} from '@material-ui/core'
import ProductCard from './ProductCard'

function Buyer() {
  return (
    <div>
      <ProductCard
      title="Cucumbers from my garden"
      subtitle="Vegetables"
      imgSrc="https://www.shethepeople.tv/wp-content/uploads/2019/05/cucumber-e1558166231577.jpg"
      description="I picked these myself. They're grown with love and without any chemicals"/>
    </div>
  );
}

export default Buyer;