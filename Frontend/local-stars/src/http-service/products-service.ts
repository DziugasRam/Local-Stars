import { HttpService } from "./http-service";

class Urls {
	public static readonly product = "/api/product";
}

export class ProductsService {
	// TODO: add Product class
	// TODO: add all of the other product related requests
	private static products: any[] = [];
	private static productsChangeListeners: (() => void)[] = [];

	private static productsListUpdated() {
		for (const listener of this.productsChangeListeners) {
			listener();
		}
	}

	public static getProducts() {
		return this.products;
	}

	public static addProductsListener(listener: () => void) {
		this.productsChangeListeners = [...this.productsChangeListeners, listener];
	}

	public static removeProductsListener(listener: () => void) {
		this.productsChangeListeners = this.productsChangeListeners.filter(l => l != listener);
	}

	public static setProducts(products: any[]) {
		this.products = products;
		this.productsListUpdated();
	}

	public static removeProduct(id: string) {
		this.setProducts(this.products.filter((p) => p.id != id));
	}

	public static async deleteProduct(productId: string) {
		const resp = await HttpService.delete(Urls.product, productId);
		if (resp.ok) this.removeProduct(productId);
		return resp.ok;
	}

	public static async updateProductData(productId: string, productData: Partial<UpdateProductData>) {
		const resp = await HttpService.put(
			`${Urls.product}?id=${productId}`,
			{ title: null, description: null, price: null, ...productData }
		);
		if (resp.ok) {
			const json = await resp.json();
			this.setProducts(this.getProducts().map((p) => (p.id == productId ? json : p)));
		}
		return resp.ok;
	}
}

interface UpdateProductData {
	title: string;
	description: string;
	price: number;
}
