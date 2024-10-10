import type { Metadata } from "next";
import "./globals.css";

export const metadata: Metadata = {
	title: "Mikulás Látogatási Kérelem",
	description: "Kérje a Mikulás látogatását!",
};

export default function RootLayout({
	children,
}: Readonly<{
	children: React.ReactNode;
}>) {
	return (
		<html lang="hu">
			<body className={`antialiased md:px-16 px-2 text-red-900`}>
				{children}
			</body>
		</html>
	);
}
