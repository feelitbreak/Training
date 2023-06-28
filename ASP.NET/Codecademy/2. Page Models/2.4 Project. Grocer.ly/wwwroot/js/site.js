// Please see documentation at https:/ / docs.microsoft.com / aspnet / core / client - side / bundling - and - minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let $totalPrice = $('#total-price');
let $quantity = $('#quantity');
let $unitPrice = $('#unit-price')
let unitPrice;
let currentQuantity;

// Executes if #total-value element is on current page
if ($totalPrice.length > 0) {
    $quantity.on('change', (event) => {
        currentQuantity = parseInt($quantity.val());
        unitPrice = Number($unitPrice.text());

        // For debugging
        // console.log('currentQuantity: ' + currentQuantity);
        // console.log('price: ' + unitPrice);
        let totalPrice = unitPrice * currentQuantity
        $totalPrice.text(totalPrice.toFixed(2));
    });
}