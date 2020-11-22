import React from 'react'
import ProductCard from './ProductCard'

function Buyer() {
  return (
    <div>
      <ProductCard
      title="Cucumbers from my garden"
      subtitle="Vegetables"
      imageUrl="https://www.shethepeople.tv/wp-content/uploads/2019/05/cucumber-e1558166231577.jpg"
      description="I picked these myself. They're grown with love and without any chemicals"
      phonenumber="861234567"
      price="0.89"
      seller="Adam12"
      />
    </div>
  );
}

export default Buyer;